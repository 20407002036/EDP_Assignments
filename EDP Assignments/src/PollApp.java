import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.HashMap;
import java.util.Map;

public class PollApp {
    private Map<String, Integer> pollResults = new HashMap<>();
    private JLabel resultsLabel;

    public PollApp() {
        JFrame frame = new JFrame("Simple Poll Application");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        // Create and configure the poll options
        pollResults.put("Red", 0);
        pollResults.put("Blue", 0);
        pollResults.put("Green", 0);

        JPanel pollPanel = new JPanel();
        pollPanel.setLayout(new GridLayout(4, 1));

        for (String color : pollResults.keySet()) {
            JRadioButton radioButton = new JRadioButton(color);
            pollPanel.add(radioButton);
        }

        JButton submitButton = new JButton("Submit");
        submitButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                updateResults();
            }
        });

        pollPanel.add(submitButton);

        resultsLabel = new JLabel("Poll Results:");
        pollPanel.add(resultsLabel);

        frame.add(pollPanel);
        frame.pack();
        frame.setVisible(true);
    }

    private void updateResults() {
        for (String color : pollResults.keySet()) {
            JRadioButton radioButton = findRadioButton(color);
            if (radioButton.isSelected()) {
                pollResults.put(color, pollResults.get(color) + 1);
                radioButton.setSelected(false);
            }
        }

        displayResults();
    }

    private JRadioButton findRadioButton(String color) {
        Container container = resultsLabel.getParent();
        Component[] components = container.getComponents();

        for (Component component : components) {
            if (component instanceof JRadioButton) {
                JRadioButton radioButton = (JRadioButton) component;
                if (radioButton.getText().equals(color)) {
                    return radioButton;
                }
            }
        }

        return null;
    }

    private void displayResults() {
        StringBuilder resultsText = new StringBuilder("Poll Results:\n");
        for (String color : pollResults.keySet()) {
            resultsText.append(color).append(": ").append(pollResults.get(color)).append(" votes\n");
        }
        resultsLabel.setText(resultsText.toString());
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> new PollApp());
    }
}
